using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesTakeQuestRewardScRsp : IMessage<PlanetFesTakeQuestRewardScRsp>, IMessage, IEquatable<PlanetFesTakeQuestRewardScRsp>, IDeepCloneable<PlanetFesTakeQuestRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesTakeQuestRewardScRsp> _parser = new MessageParser<PlanetFesTakeQuestRewardScRsp>(() => new PlanetFesTakeQuestRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EAPHMPIDECIFieldNumber = 6;

	private JNBGIDELOGF eAPHMPIDECI_;

	public const int QuestIdFieldNumber = 7;

	private uint questId_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesTakeQuestRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesTakeQuestRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNBGIDELOGF EAPHMPIDECI
	{
		get
		{
			return eAPHMPIDECI_;
		}
		set
		{
			eAPHMPIDECI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QuestId
	{
		get
		{
			return questId_;
		}
		set
		{
			questId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesTakeQuestRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesTakeQuestRewardScRsp(PlanetFesTakeQuestRewardScRsp other)
		: this()
	{
		eAPHMPIDECI_ = ((other.eAPHMPIDECI_ != null) ? other.eAPHMPIDECI_.Clone() : null);
		questId_ = other.questId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesTakeQuestRewardScRsp Clone()
	{
		return new PlanetFesTakeQuestRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesTakeQuestRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesTakeQuestRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EAPHMPIDECI, other.EAPHMPIDECI))
		{
			return false;
		}
		if (QuestId != other.QuestId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (eAPHMPIDECI_ != null)
		{
			num ^= EAPHMPIDECI.GetHashCode();
		}
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (eAPHMPIDECI_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EAPHMPIDECI);
		}
		if (QuestId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(QuestId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
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
		if (eAPHMPIDECI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAPHMPIDECI);
		}
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QuestId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesTakeQuestRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eAPHMPIDECI_ != null)
		{
			if (eAPHMPIDECI_ == null)
			{
				EAPHMPIDECI = new JNBGIDELOGF();
			}
			EAPHMPIDECI.MergeFrom(other.EAPHMPIDECI);
		}
		if (other.QuestId != 0)
		{
			QuestId = other.QuestId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 50u:
				if (eAPHMPIDECI_ == null)
				{
					EAPHMPIDECI = new JNBGIDELOGF();
				}
				input.ReadMessage(EAPHMPIDECI);
				break;
			case 56u:
				QuestId = input.ReadUInt32();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
