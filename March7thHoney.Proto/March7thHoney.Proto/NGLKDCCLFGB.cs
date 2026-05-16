using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NGLKDCCLFGB : IMessage<NGLKDCCLFGB>, IMessage, IEquatable<NGLKDCCLFGB>, IDeepCloneable<NGLKDCCLFGB>, IBufferMessage
{
	private static readonly MessageParser<NGLKDCCLFGB> _parser = new MessageParser<NGLKDCCLFGB>(() => new NGLKDCCLFGB());

	private UnknownFieldSet _unknownFields;

	public const int GMPEBBHFLHIFieldNumber = 1;

	private BBPCCHGJCPF gMPEBBHFLHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NGLKDCCLFGB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NGLKDCCLFGBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBPCCHGJCPF GMPEBBHFLHI
	{
		get
		{
			return gMPEBBHFLHI_;
		}
		set
		{
			gMPEBBHFLHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGLKDCCLFGB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGLKDCCLFGB(NGLKDCCLFGB other)
		: this()
	{
		gMPEBBHFLHI_ = ((other.gMPEBBHFLHI_ != null) ? other.gMPEBBHFLHI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGLKDCCLFGB Clone()
	{
		return new NGLKDCCLFGB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NGLKDCCLFGB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NGLKDCCLFGB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GMPEBBHFLHI, other.GMPEBBHFLHI))
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
		if (gMPEBBHFLHI_ != null)
		{
			num ^= GMPEBBHFLHI.GetHashCode();
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
		if (gMPEBBHFLHI_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GMPEBBHFLHI);
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
		if (gMPEBBHFLHI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GMPEBBHFLHI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NGLKDCCLFGB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gMPEBBHFLHI_ != null)
		{
			if (gMPEBBHFLHI_ == null)
			{
				GMPEBBHFLHI = new BBPCCHGJCPF();
			}
			GMPEBBHFLHI.MergeFrom(other.GMPEBBHFLHI);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (gMPEBBHFLHI_ == null)
			{
				GMPEBBHFLHI = new BBPCCHGJCPF();
			}
			input.ReadMessage(GMPEBBHFLHI);
		}
	}
}
