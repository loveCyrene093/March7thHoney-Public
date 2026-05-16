using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKJADKLIBEH : IMessage<HKJADKLIBEH>, IMessage, IEquatable<HKJADKLIBEH>, IDeepCloneable<HKJADKLIBEH>, IBufferMessage
{
	private static readonly MessageParser<HKJADKLIBEH> _parser = new MessageParser<HKJADKLIBEH>(() => new HKJADKLIBEH());

	private UnknownFieldSet _unknownFields;

	public const int OFCKHGLINAGFieldNumber = 8;

	private MAGFKFCMLJM oFCKHGLINAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKJADKLIBEH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKJADKLIBEHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGFKFCMLJM OFCKHGLINAG
	{
		get
		{
			return oFCKHGLINAG_;
		}
		set
		{
			oFCKHGLINAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJADKLIBEH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJADKLIBEH(HKJADKLIBEH other)
		: this()
	{
		oFCKHGLINAG_ = ((other.oFCKHGLINAG_ != null) ? other.oFCKHGLINAG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKJADKLIBEH Clone()
	{
		return new HKJADKLIBEH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKJADKLIBEH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKJADKLIBEH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OFCKHGLINAG, other.OFCKHGLINAG))
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
		if (oFCKHGLINAG_ != null)
		{
			num ^= OFCKHGLINAG.GetHashCode();
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
		if (oFCKHGLINAG_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(OFCKHGLINAG);
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
		if (oFCKHGLINAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFCKHGLINAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKJADKLIBEH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oFCKHGLINAG_ != null)
		{
			if (oFCKHGLINAG_ == null)
			{
				OFCKHGLINAG = new MAGFKFCMLJM();
			}
			OFCKHGLINAG.MergeFrom(other.OFCKHGLINAG);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oFCKHGLINAG_ == null)
			{
				OFCKHGLINAG = new MAGFKFCMLJM();
			}
			input.ReadMessage(OFCKHGLINAG);
		}
	}
}
