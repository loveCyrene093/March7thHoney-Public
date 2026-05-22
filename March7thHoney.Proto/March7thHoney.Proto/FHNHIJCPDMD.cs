using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FHNHIJCPDMD : IMessage<FHNHIJCPDMD>, IMessage, IEquatable<FHNHIJCPDMD>, IDeepCloneable<FHNHIJCPDMD>, IBufferMessage
{
	private static readonly MessageParser<FHNHIJCPDMD> _parser = new MessageParser<FHNHIJCPDMD>(() => new FHNHIJCPDMD());

	private UnknownFieldSet _unknownFields;

	public const int KIOBOCMOONHFieldNumber = 3;

	private MKOPHCBPOMM kIOBOCMOONH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FHNHIJCPDMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FHNHIJCPDMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKOPHCBPOMM KIOBOCMOONH
	{
		get
		{
			return kIOBOCMOONH_;
		}
		set
		{
			kIOBOCMOONH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHNHIJCPDMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHNHIJCPDMD(FHNHIJCPDMD other)
		: this()
	{
		kIOBOCMOONH_ = ((other.kIOBOCMOONH_ != null) ? other.kIOBOCMOONH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHNHIJCPDMD Clone()
	{
		return new FHNHIJCPDMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FHNHIJCPDMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FHNHIJCPDMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KIOBOCMOONH, other.KIOBOCMOONH))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (kIOBOCMOONH_ != null)
		{
			num ^= KIOBOCMOONH.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (kIOBOCMOONH_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KIOBOCMOONH);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (kIOBOCMOONH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KIOBOCMOONH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FHNHIJCPDMD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kIOBOCMOONH_ != null)
		{
			if (kIOBOCMOONH_ == null)
			{
				KIOBOCMOONH = new MKOPHCBPOMM();
			}
			KIOBOCMOONH.MergeFrom(other.KIOBOCMOONH);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kIOBOCMOONH_ == null)
			{
				KIOBOCMOONH = new MKOPHCBPOMM();
			}
			input.ReadMessage(KIOBOCMOONH);
		}
	}
}
