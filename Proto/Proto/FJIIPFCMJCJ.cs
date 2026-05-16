using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FJIIPFCMJCJ : IMessage<FJIIPFCMJCJ>, IMessage, IEquatable<FJIIPFCMJCJ>, IDeepCloneable<FJIIPFCMJCJ>, IBufferMessage
{
	private static readonly MessageParser<FJIIPFCMJCJ> _parser = new MessageParser<FJIIPFCMJCJ>(() => new FJIIPFCMJCJ());

	private UnknownFieldSet _unknownFields;

	public const int ENPGAGBMHOEFieldNumber = 3;

	private DOGGIDNINJP eNPGAGBMHOE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FJIIPFCMJCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FJIIPFCMJCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOGGIDNINJP ENPGAGBMHOE
	{
		get
		{
			return eNPGAGBMHOE_;
		}
		set
		{
			eNPGAGBMHOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJIIPFCMJCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJIIPFCMJCJ(FJIIPFCMJCJ other)
		: this()
	{
		eNPGAGBMHOE_ = ((other.eNPGAGBMHOE_ != null) ? other.eNPGAGBMHOE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJIIPFCMJCJ Clone()
	{
		return new FJIIPFCMJCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FJIIPFCMJCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FJIIPFCMJCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ENPGAGBMHOE, other.ENPGAGBMHOE))
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
		if (eNPGAGBMHOE_ != null)
		{
			num ^= ENPGAGBMHOE.GetHashCode();
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
		if (eNPGAGBMHOE_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ENPGAGBMHOE);
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
		if (eNPGAGBMHOE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENPGAGBMHOE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FJIIPFCMJCJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eNPGAGBMHOE_ != null)
		{
			if (eNPGAGBMHOE_ == null)
			{
				ENPGAGBMHOE = new DOGGIDNINJP();
			}
			ENPGAGBMHOE.MergeFrom(other.ENPGAGBMHOE);
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
			if (eNPGAGBMHOE_ == null)
			{
				ENPGAGBMHOE = new DOGGIDNINJP();
			}
			input.ReadMessage(ENPGAGBMHOE);
		}
	}
}
