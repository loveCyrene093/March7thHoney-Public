using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FNJJCIGJIKC : IMessage<FNJJCIGJIKC>, IMessage, IEquatable<FNJJCIGJIKC>, IDeepCloneable<FNJJCIGJIKC>, IBufferMessage
{
	private static readonly MessageParser<FNJJCIGJIKC> _parser = new MessageParser<FNJJCIGJIKC>(() => new FNJJCIGJIKC());

	private UnknownFieldSet _unknownFields;

	public const int WorldLevelFieldNumber = 1;

	private uint worldLevel_;

	public const int LineupFieldNumber = 9;

	private LineupInfo lineup_;

	public const int FHJEOAKDCBCFieldNumber = 11;

	private SceneInfo fHJEOAKDCBC_;

	public const int RaidIdFieldNumber = 13;

	private uint raidId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FNJJCIGJIKC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FNJJCIGJIKCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneInfo FHJEOAKDCBC
	{
		get
		{
			return fHJEOAKDCBC_;
		}
		set
		{
			fHJEOAKDCBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RaidId
	{
		get
		{
			return raidId_;
		}
		set
		{
			raidId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJCIGJIKC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJCIGJIKC(FNJJCIGJIKC other)
		: this()
	{
		worldLevel_ = other.worldLevel_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		fHJEOAKDCBC_ = ((other.fHJEOAKDCBC_ != null) ? other.fHJEOAKDCBC_.Clone() : null);
		raidId_ = other.raidId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJCIGJIKC Clone()
	{
		return new FNJJCIGJIKC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FNJJCIGJIKC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FNJJCIGJIKC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!object.Equals(FHJEOAKDCBC, other.FHJEOAKDCBC))
		{
			return false;
		}
		if (RaidId != other.RaidId)
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
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (fHJEOAKDCBC_ != null)
		{
			num ^= FHJEOAKDCBC.GetHashCode();
		}
		if (RaidId != 0)
		{
			num ^= RaidId.GetHashCode();
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
		if (WorldLevel != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(WorldLevel);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Lineup);
		}
		if (fHJEOAKDCBC_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FHJEOAKDCBC);
		}
		if (RaidId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(RaidId);
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
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (fHJEOAKDCBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHJEOAKDCBC);
		}
		if (RaidId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RaidId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FNJJCIGJIKC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new LineupInfo();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.fHJEOAKDCBC_ != null)
		{
			if (fHJEOAKDCBC_ == null)
			{
				FHJEOAKDCBC = new SceneInfo();
			}
			FHJEOAKDCBC.MergeFrom(other.FHJEOAKDCBC);
		}
		if (other.RaidId != 0)
		{
			RaidId = other.RaidId;
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
			case 8u:
				WorldLevel = input.ReadUInt32();
				break;
			case 74u:
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 90u:
				if (fHJEOAKDCBC_ == null)
				{
					FHJEOAKDCBC = new SceneInfo();
				}
				input.ReadMessage(FHJEOAKDCBC);
				break;
			case 104u:
				RaidId = input.ReadUInt32();
				break;
			}
		}
	}
}
