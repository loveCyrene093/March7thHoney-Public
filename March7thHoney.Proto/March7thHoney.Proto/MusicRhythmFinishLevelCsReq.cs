using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmFinishLevelCsReq : IMessage<MusicRhythmFinishLevelCsReq>, IMessage, IEquatable<MusicRhythmFinishLevelCsReq>, IDeepCloneable<MusicRhythmFinishLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmFinishLevelCsReq> _parser = new MessageParser<MusicRhythmFinishLevelCsReq>(() => new MusicRhythmFinishLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 1;

	private uint scoreId_;

	public const int FullComboFieldNumber = 12;

	private bool fullCombo_;

	public const int RoleStarFieldNumber = 15;

	private uint roleStar_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmFinishLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmFinishLevelCsReqReflection.Descriptor.MessageTypes[0];

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
	public bool FullCombo
	{
		get
		{
			return fullCombo_;
		}
		set
		{
			fullCombo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleStar
	{
		get
		{
			return roleStar_;
		}
		set
		{
			roleStar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmFinishLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmFinishLevelCsReq(MusicRhythmFinishLevelCsReq other)
		: this()
	{
		scoreId_ = other.scoreId_;
		fullCombo_ = other.fullCombo_;
		roleStar_ = other.roleStar_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmFinishLevelCsReq Clone()
	{
		return new MusicRhythmFinishLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmFinishLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmFinishLevelCsReq other)
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
		if (FullCombo != other.FullCombo)
		{
			return false;
		}
		if (RoleStar != other.RoleStar)
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
		if (FullCombo)
		{
			num ^= FullCombo.GetHashCode();
		}
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(ScoreId);
		}
		if (FullCombo)
		{
			output.WriteRawTag(96);
			output.WriteBool(FullCombo);
		}
		if (RoleStar != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RoleStar);
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
		if (FullCombo)
		{
			num += 2;
		}
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmFinishLevelCsReq other)
	{
		if (other != null)
		{
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.FullCombo)
			{
				FullCombo = other.FullCombo;
			}
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
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
			case 8u:
				ScoreId = input.ReadUInt32();
				break;
			case 96u:
				FullCombo = input.ReadBool();
				break;
			case 120u:
				RoleStar = input.ReadUInt32();
				break;
			}
		}
	}
}
