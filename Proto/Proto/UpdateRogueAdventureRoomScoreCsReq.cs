using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateRogueAdventureRoomScoreCsReq : IMessage<UpdateRogueAdventureRoomScoreCsReq>, IMessage, IEquatable<UpdateRogueAdventureRoomScoreCsReq>, IDeepCloneable<UpdateRogueAdventureRoomScoreCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateRogueAdventureRoomScoreCsReq> _parser = new MessageParser<UpdateRogueAdventureRoomScoreCsReq>(() => new UpdateRogueAdventureRoomScoreCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 6;

	private uint scoreId_;

	public const int NIIEKCMBENIFieldNumber = 8;

	private uint nIIEKCMBENI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateRogueAdventureRoomScoreCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateRogueAdventureRoomScoreCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NIIEKCMBENI
	{
		get
		{
			return nIIEKCMBENI_;
		}
		set
		{
			nIIEKCMBENI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateRogueAdventureRoomScoreCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateRogueAdventureRoomScoreCsReq(UpdateRogueAdventureRoomScoreCsReq other)
		: this()
	{
		scoreId_ = other.scoreId_;
		nIIEKCMBENI_ = other.nIIEKCMBENI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateRogueAdventureRoomScoreCsReq Clone()
	{
		return new UpdateRogueAdventureRoomScoreCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateRogueAdventureRoomScoreCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateRogueAdventureRoomScoreCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (NIIEKCMBENI != other.NIIEKCMBENI)
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
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (NIIEKCMBENI != 0)
		{
			num ^= NIIEKCMBENI.GetHashCode();
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
		if (ScoreId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ScoreId);
		}
		if (NIIEKCMBENI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NIIEKCMBENI);
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
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (NIIEKCMBENI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIIEKCMBENI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateRogueAdventureRoomScoreCsReq other)
	{
		if (other != null)
		{
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.NIIEKCMBENI != 0)
			{
				NIIEKCMBENI = other.NIIEKCMBENI;
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
			case 48u:
				ScoreId = input.ReadUInt32();
				break;
			case 64u:
				NIIEKCMBENI = input.ReadUInt32();
				break;
			}
		}
	}
}
