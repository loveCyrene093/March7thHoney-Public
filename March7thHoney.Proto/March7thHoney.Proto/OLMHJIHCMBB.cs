using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OLMHJIHCMBB : IMessage<OLMHJIHCMBB>, IMessage, IEquatable<OLMHJIHCMBB>, IDeepCloneable<OLMHJIHCMBB>, IBufferMessage
{
	private static readonly MessageParser<OLMHJIHCMBB> _parser = new MessageParser<OLMHJIHCMBB>(() => new OLMHJIHCMBB());

	private UnknownFieldSet _unknownFields;

	public const int MFMJBFDFMHGFieldNumber = 5;

	private uint mFMJBFDFMHG_;

	public const int JANGNOODOINFieldNumber = 6;

	private uint jANGNOODOIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OLMHJIHCMBB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OLMHJIHCMBBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFMJBFDFMHG
	{
		get
		{
			return mFMJBFDFMHG_;
		}
		set
		{
			mFMJBFDFMHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JANGNOODOIN
	{
		get
		{
			return jANGNOODOIN_;
		}
		set
		{
			jANGNOODOIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLMHJIHCMBB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLMHJIHCMBB(OLMHJIHCMBB other)
		: this()
	{
		mFMJBFDFMHG_ = other.mFMJBFDFMHG_;
		jANGNOODOIN_ = other.jANGNOODOIN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLMHJIHCMBB Clone()
	{
		return new OLMHJIHCMBB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OLMHJIHCMBB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OLMHJIHCMBB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFMJBFDFMHG != other.MFMJBFDFMHG)
		{
			return false;
		}
		if (JANGNOODOIN != other.JANGNOODOIN)
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
		if (MFMJBFDFMHG != 0)
		{
			num ^= MFMJBFDFMHG.GetHashCode();
		}
		if (JANGNOODOIN != 0)
		{
			num ^= JANGNOODOIN.GetHashCode();
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
		if (MFMJBFDFMHG != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MFMJBFDFMHG);
		}
		if (JANGNOODOIN != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JANGNOODOIN);
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
		if (MFMJBFDFMHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFMJBFDFMHG);
		}
		if (JANGNOODOIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JANGNOODOIN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OLMHJIHCMBB other)
	{
		if (other != null)
		{
			if (other.MFMJBFDFMHG != 0)
			{
				MFMJBFDFMHG = other.MFMJBFDFMHG;
			}
			if (other.JANGNOODOIN != 0)
			{
				JANGNOODOIN = other.JANGNOODOIN;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
				MFMJBFDFMHG = input.ReadUInt32();
				break;
			case 48u:
				JANGNOODOIN = input.ReadUInt32();
				break;
			}
		}
	}
}
