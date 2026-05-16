using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADLDDMAIFAI : IMessage<ADLDDMAIFAI>, IMessage, IEquatable<ADLDDMAIFAI>, IDeepCloneable<ADLDDMAIFAI>, IBufferMessage
{
	private static readonly MessageParser<ADLDDMAIFAI> _parser = new MessageParser<ADLDDMAIFAI>(() => new ADLDDMAIFAI());

	private UnknownFieldSet _unknownFields;

	public const int MJDMLOIHLPAFieldNumber = 12;

	private PCDAHKGMGNB mJDMLOIHLPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADLDDMAIFAI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADLDDMAIFAIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCDAHKGMGNB MJDMLOIHLPA
	{
		get
		{
			return mJDMLOIHLPA_;
		}
		set
		{
			mJDMLOIHLPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADLDDMAIFAI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADLDDMAIFAI(ADLDDMAIFAI other)
		: this()
	{
		mJDMLOIHLPA_ = other.mJDMLOIHLPA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADLDDMAIFAI Clone()
	{
		return new ADLDDMAIFAI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADLDDMAIFAI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADLDDMAIFAI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MJDMLOIHLPA != other.MJDMLOIHLPA)
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
		if (MJDMLOIHLPA != PCDAHKGMGNB.Pcpdhelpkem)
		{
			num ^= MJDMLOIHLPA.GetHashCode();
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
		if (MJDMLOIHLPA != PCDAHKGMGNB.Pcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)MJDMLOIHLPA);
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
		if (MJDMLOIHLPA != PCDAHKGMGNB.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MJDMLOIHLPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADLDDMAIFAI other)
	{
		if (other != null)
		{
			if (other.MJDMLOIHLPA != PCDAHKGMGNB.Pcpdhelpkem)
			{
				MJDMLOIHLPA = other.MJDMLOIHLPA;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				MJDMLOIHLPA = (PCDAHKGMGNB)input.ReadEnum();
			}
		}
	}
}
