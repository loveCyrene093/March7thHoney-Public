using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MakeDrinkCsReq : IMessage<MakeDrinkCsReq>, IMessage, IEquatable<MakeDrinkCsReq>, IDeepCloneable<MakeDrinkCsReq>, IBufferMessage
{
	private static readonly MessageParser<MakeDrinkCsReq> _parser = new MessageParser<MakeDrinkCsReq>(() => new MakeDrinkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MGGEPANJPLPFieldNumber = 2;

	private uint mGGEPANJPLP_;

	public const int IHDMLHFAEKHFieldNumber = 8;

	private CIGKBDIGGOI iHDMLHFAEKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MakeDrinkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MakeDrinkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGGEPANJPLP
	{
		get
		{
			return mGGEPANJPLP_;
		}
		set
		{
			mGGEPANJPLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI IHDMLHFAEKH
	{
		get
		{
			return iHDMLHFAEKH_;
		}
		set
		{
			iHDMLHFAEKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeDrinkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeDrinkCsReq(MakeDrinkCsReq other)
		: this()
	{
		mGGEPANJPLP_ = other.mGGEPANJPLP_;
		iHDMLHFAEKH_ = ((other.iHDMLHFAEKH_ != null) ? other.iHDMLHFAEKH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MakeDrinkCsReq Clone()
	{
		return new MakeDrinkCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MakeDrinkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MakeDrinkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGGEPANJPLP != other.MGGEPANJPLP)
		{
			return false;
		}
		if (!object.Equals(IHDMLHFAEKH, other.IHDMLHFAEKH))
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
		if (MGGEPANJPLP != 0)
		{
			num ^= MGGEPANJPLP.GetHashCode();
		}
		if (iHDMLHFAEKH_ != null)
		{
			num ^= IHDMLHFAEKH.GetHashCode();
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
		if (MGGEPANJPLP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MGGEPANJPLP);
		}
		if (iHDMLHFAEKH_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IHDMLHFAEKH);
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
		if (MGGEPANJPLP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGGEPANJPLP);
		}
		if (iHDMLHFAEKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHDMLHFAEKH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MakeDrinkCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MGGEPANJPLP != 0)
		{
			MGGEPANJPLP = other.MGGEPANJPLP;
		}
		if (other.iHDMLHFAEKH_ != null)
		{
			if (iHDMLHFAEKH_ == null)
			{
				IHDMLHFAEKH = new CIGKBDIGGOI();
			}
			IHDMLHFAEKH.MergeFrom(other.IHDMLHFAEKH);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				MGGEPANJPLP = input.ReadUInt32();
				break;
			case 66u:
				if (iHDMLHFAEKH_ == null)
				{
					IHDMLHFAEKH = new CIGKBDIGGOI();
				}
				input.ReadMessage(IHDMLHFAEKH);
				break;
			}
		}
	}
}
