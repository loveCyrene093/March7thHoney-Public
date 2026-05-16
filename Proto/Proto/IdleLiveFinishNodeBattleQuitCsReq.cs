using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveFinishNodeBattleQuitCsReq : IMessage<IdleLiveFinishNodeBattleQuitCsReq>, IMessage, IEquatable<IdleLiveFinishNodeBattleQuitCsReq>, IDeepCloneable<IdleLiveFinishNodeBattleQuitCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveFinishNodeBattleQuitCsReq> _parser = new MessageParser<IdleLiveFinishNodeBattleQuitCsReq>(() => new IdleLiveFinishNodeBattleQuitCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LMLFOELDMJDFieldNumber = 7;

	private KGFMBNIIPPA lMLFOELDMJD_;

	public const int MNLBMALDPEJFieldNumber = 15;

	private KFNFHIAEKIN mNLBMALDPEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveFinishNodeBattleQuitCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveFinishNodeBattleQuitCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGFMBNIIPPA LMLFOELDMJD
	{
		get
		{
			return lMLFOELDMJD_;
		}
		set
		{
			lMLFOELDMJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFNFHIAEKIN MNLBMALDPEJ
	{
		get
		{
			return mNLBMALDPEJ_;
		}
		set
		{
			mNLBMALDPEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveFinishNodeBattleQuitCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveFinishNodeBattleQuitCsReq(IdleLiveFinishNodeBattleQuitCsReq other)
		: this()
	{
		lMLFOELDMJD_ = other.lMLFOELDMJD_;
		mNLBMALDPEJ_ = ((other.mNLBMALDPEJ_ != null) ? other.mNLBMALDPEJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveFinishNodeBattleQuitCsReq Clone()
	{
		return new IdleLiveFinishNodeBattleQuitCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveFinishNodeBattleQuitCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveFinishNodeBattleQuitCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LMLFOELDMJD != other.LMLFOELDMJD)
		{
			return false;
		}
		if (!object.Equals(MNLBMALDPEJ, other.MNLBMALDPEJ))
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
		if (LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			num ^= LMLFOELDMJD.GetHashCode();
		}
		if (mNLBMALDPEJ_ != null)
		{
			num ^= MNLBMALDPEJ.GetHashCode();
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
		if (LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)LMLFOELDMJD);
		}
		if (mNLBMALDPEJ_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(MNLBMALDPEJ);
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
		if (LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LMLFOELDMJD);
		}
		if (mNLBMALDPEJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNLBMALDPEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveFinishNodeBattleQuitCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LMLFOELDMJD != KGFMBNIIPPA.Hhhakhmohbb)
		{
			LMLFOELDMJD = other.LMLFOELDMJD;
		}
		if (other.mNLBMALDPEJ_ != null)
		{
			if (mNLBMALDPEJ_ == null)
			{
				MNLBMALDPEJ = new KFNFHIAEKIN();
			}
			MNLBMALDPEJ.MergeFrom(other.MNLBMALDPEJ);
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
			case 56u:
				LMLFOELDMJD = (KGFMBNIIPPA)input.ReadEnum();
				break;
			case 122u:
				if (mNLBMALDPEJ_ == null)
				{
					MNLBMALDPEJ = new KFNFHIAEKIN();
				}
				input.ReadMessage(MNLBMALDPEJ);
				break;
			}
		}
	}
}
