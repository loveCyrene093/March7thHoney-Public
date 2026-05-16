using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EvolveBuildStartLevelCsReq : IMessage<EvolveBuildStartLevelCsReq>, IMessage, IEquatable<EvolveBuildStartLevelCsReq>, IDeepCloneable<EvolveBuildStartLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<EvolveBuildStartLevelCsReq> _parser = new MessageParser<EvolveBuildStartLevelCsReq>(() => new EvolveBuildStartLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EDDJGNNOCAGFieldNumber = 6;

	private HHIPKINNCAP eDDJGNNOCAG_;

	public const int LevelIdFieldNumber = 9;

	private uint levelId_;

	public const int AvatarListFieldNumber = 12;

	private static readonly FieldCodec<MOEDGOHOALP> _repeated_avatarList_codec = FieldCodec.ForMessage(98u, MOEDGOHOALP.Parser);

	private readonly RepeatedField<MOEDGOHOALP> avatarList_ = new RepeatedField<MOEDGOHOALP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvolveBuildStartLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvolveBuildStartLevelCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIPKINNCAP EDDJGNNOCAG
	{
		get
		{
			return eDDJGNNOCAG_;
		}
		set
		{
			eDDJGNNOCAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MOEDGOHOALP> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildStartLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildStartLevelCsReq(EvolveBuildStartLevelCsReq other)
		: this()
	{
		eDDJGNNOCAG_ = ((other.eDDJGNNOCAG_ != null) ? other.eDDJGNNOCAG_.Clone() : null);
		levelId_ = other.levelId_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildStartLevelCsReq Clone()
	{
		return new EvolveBuildStartLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvolveBuildStartLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvolveBuildStartLevelCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EDDJGNNOCAG, other.EDDJGNNOCAG))
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (eDDJGNNOCAG_ != null)
		{
			num ^= EDDJGNNOCAG.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (eDDJGNNOCAG_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EDDJGNNOCAG);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LevelId);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (eDDJGNNOCAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDDJGNNOCAG);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvolveBuildStartLevelCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eDDJGNNOCAG_ != null)
		{
			if (eDDJGNNOCAG_ == null)
			{
				EDDJGNNOCAG = new HHIPKINNCAP();
			}
			EDDJGNNOCAG.MergeFrom(other.EDDJGNNOCAG);
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		avatarList_.Add(other.avatarList_);
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
				if (eDDJGNNOCAG_ == null)
				{
					EDDJGNNOCAG = new HHIPKINNCAP();
				}
				input.ReadMessage(EDDJGNNOCAG);
				break;
			case 72u:
				LevelId = input.ReadUInt32();
				break;
			case 98u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
