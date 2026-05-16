using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmLevel : IMessage<MusicRhythmLevel>, IMessage, IEquatable<MusicRhythmLevel>, IDeepCloneable<MusicRhythmLevel>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmLevel> _parser = new MessageParser<MusicRhythmLevel>(() => new MusicRhythmLevel());

	private UnknownFieldSet _unknownFields;

	public const int UnlockLevelFieldNumber = 5;

	private uint unlockLevel_;

	public const int FullComboFieldNumber = 6;

	private bool fullCombo_;

	public const int LevelIdFieldNumber = 8;

	private uint levelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmLevel> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmLevelReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UnlockLevel
	{
		get
		{
			return unlockLevel_;
		}
		set
		{
			unlockLevel_ = value;
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
	public MusicRhythmLevel()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmLevel(MusicRhythmLevel other)
		: this()
	{
		unlockLevel_ = other.unlockLevel_;
		fullCombo_ = other.fullCombo_;
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmLevel Clone()
	{
		return new MusicRhythmLevel(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmLevel);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmLevel other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnlockLevel != other.UnlockLevel)
		{
			return false;
		}
		if (FullCombo != other.FullCombo)
		{
			return false;
		}
		if (LevelId != other.LevelId)
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
		if (UnlockLevel != 0)
		{
			num ^= UnlockLevel.GetHashCode();
		}
		if (FullCombo)
		{
			num ^= FullCombo.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
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
		if (UnlockLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UnlockLevel);
		}
		if (FullCombo)
		{
			output.WriteRawTag(48);
			output.WriteBool(FullCombo);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LevelId);
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
		if (UnlockLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UnlockLevel);
		}
		if (FullCombo)
		{
			num += 2;
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmLevel other)
	{
		if (other != null)
		{
			if (other.UnlockLevel != 0)
			{
				UnlockLevel = other.UnlockLevel;
			}
			if (other.FullCombo)
			{
				FullCombo = other.FullCombo;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
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
				UnlockLevel = input.ReadUInt32();
				break;
			case 48u:
				FullCombo = input.ReadBool();
				break;
			case 64u:
				LevelId = input.ReadUInt32();
				break;
			}
		}
	}
}
