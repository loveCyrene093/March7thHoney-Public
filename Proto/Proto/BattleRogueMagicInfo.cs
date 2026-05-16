using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleRogueMagicInfo : IMessage<BattleRogueMagicInfo>, IMessage, IEquatable<BattleRogueMagicInfo>, IDeepCloneable<BattleRogueMagicInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleRogueMagicInfo> _parser = new MessageParser<BattleRogueMagicInfo>(() => new BattleRogueMagicInfo());

	private UnknownFieldSet _unknownFields;

	public const int IMPOEHIOCBCFieldNumber = 1;

	private NGJPJANLDHI iMPOEHIOCBC_;

	public const int DetailInfoFieldNumber = 2;

	private FIHMEHKCDAL detailInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleRogueMagicInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleRogueMagicInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGJPJANLDHI IMPOEHIOCBC
	{
		get
		{
			return iMPOEHIOCBC_;
		}
		set
		{
			iMPOEHIOCBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIHMEHKCDAL DetailInfo
	{
		get
		{
			return detailInfo_;
		}
		set
		{
			detailInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRogueMagicInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRogueMagicInfo(BattleRogueMagicInfo other)
		: this()
	{
		iMPOEHIOCBC_ = ((other.iMPOEHIOCBC_ != null) ? other.iMPOEHIOCBC_.Clone() : null);
		detailInfo_ = ((other.detailInfo_ != null) ? other.detailInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRogueMagicInfo Clone()
	{
		return new BattleRogueMagicInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleRogueMagicInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleRogueMagicInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IMPOEHIOCBC, other.IMPOEHIOCBC))
		{
			return false;
		}
		if (!object.Equals(DetailInfo, other.DetailInfo))
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
		if (iMPOEHIOCBC_ != null)
		{
			num ^= IMPOEHIOCBC.GetHashCode();
		}
		if (detailInfo_ != null)
		{
			num ^= DetailInfo.GetHashCode();
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
		if (iMPOEHIOCBC_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(IMPOEHIOCBC);
		}
		if (detailInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(DetailInfo);
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
		if (iMPOEHIOCBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPOEHIOCBC);
		}
		if (detailInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DetailInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleRogueMagicInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iMPOEHIOCBC_ != null)
		{
			if (iMPOEHIOCBC_ == null)
			{
				IMPOEHIOCBC = new NGJPJANLDHI();
			}
			IMPOEHIOCBC.MergeFrom(other.IMPOEHIOCBC);
		}
		if (other.detailInfo_ != null)
		{
			if (detailInfo_ == null)
			{
				DetailInfo = new FIHMEHKCDAL();
			}
			DetailInfo.MergeFrom(other.DetailInfo);
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
			case 10u:
				if (iMPOEHIOCBC_ == null)
				{
					IMPOEHIOCBC = new NGJPJANLDHI();
				}
				input.ReadMessage(IMPOEHIOCBC);
				break;
			case 18u:
				if (detailInfo_ == null)
				{
					DetailInfo = new FIHMEHKCDAL();
				}
				input.ReadMessage(DetailInfo);
				break;
			}
		}
	}
}
