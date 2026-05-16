using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournEnterRogueCocoonSceneCsReq : IMessage<RogueTournEnterRogueCocoonSceneCsReq>, IMessage, IEquatable<RogueTournEnterRogueCocoonSceneCsReq>, IDeepCloneable<RogueTournEnterRogueCocoonSceneCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournEnterRogueCocoonSceneCsReq> _parser = new MessageParser<RogueTournEnterRogueCocoonSceneCsReq>(() => new RogueTournEnterRogueCocoonSceneCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NBDHADPNGNHFieldNumber = 1;

	private bool nBDHADPNGNH_;

	public const int CountFieldNumber = 2;

	private uint count_;

	public const int JOMHEIHLLDMFieldNumber = 3;

	private uint jOMHEIHLLDM_;

	public const int AvatarListFieldNumber = 6;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_avatarList_codec = FieldCodec.ForMessage(50u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> avatarList_ = new RepeatedField<EEBPHJCNBFO>();

	public const int DifficultyLevelFieldNumber = 9;

	private uint difficultyLevel_;

	public const int LJPLIHEPGHAFieldNumber = 10;

	private uint lJPLIHEPGHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournEnterRogueCocoonSceneCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournEnterRogueCocoonSceneCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NBDHADPNGNH
	{
		get
		{
			return nBDHADPNGNH_;
		}
		set
		{
			nBDHADPNGNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JOMHEIHLLDM
	{
		get
		{
			return jOMHEIHLLDM_;
		}
		set
		{
			jOMHEIHLLDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJPLIHEPGHA
	{
		get
		{
			return lJPLIHEPGHA_;
		}
		set
		{
			lJPLIHEPGHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnterRogueCocoonSceneCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnterRogueCocoonSceneCsReq(RogueTournEnterRogueCocoonSceneCsReq other)
		: this()
	{
		nBDHADPNGNH_ = other.nBDHADPNGNH_;
		count_ = other.count_;
		jOMHEIHLLDM_ = other.jOMHEIHLLDM_;
		avatarList_ = other.avatarList_.Clone();
		difficultyLevel_ = other.difficultyLevel_;
		lJPLIHEPGHA_ = other.lJPLIHEPGHA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnterRogueCocoonSceneCsReq Clone()
	{
		return new RogueTournEnterRogueCocoonSceneCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournEnterRogueCocoonSceneCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournEnterRogueCocoonSceneCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NBDHADPNGNH != other.NBDHADPNGNH)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (JOMHEIHLLDM != other.JOMHEIHLLDM)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (LJPLIHEPGHA != other.LJPLIHEPGHA)
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
		if (NBDHADPNGNH)
		{
			num ^= NBDHADPNGNH.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (JOMHEIHLLDM != 0)
		{
			num ^= JOMHEIHLLDM.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (LJPLIHEPGHA != 0)
		{
			num ^= LJPLIHEPGHA.GetHashCode();
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
		if (NBDHADPNGNH)
		{
			output.WriteRawTag(8);
			output.WriteBool(NBDHADPNGNH);
		}
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
		}
		if (JOMHEIHLLDM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JOMHEIHLLDM);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DifficultyLevel);
		}
		if (LJPLIHEPGHA != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LJPLIHEPGHA);
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
		if (NBDHADPNGNH)
		{
			num += 2;
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (JOMHEIHLLDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JOMHEIHLLDM);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (LJPLIHEPGHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJPLIHEPGHA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournEnterRogueCocoonSceneCsReq other)
	{
		if (other != null)
		{
			if (other.NBDHADPNGNH)
			{
				NBDHADPNGNH = other.NBDHADPNGNH;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.JOMHEIHLLDM != 0)
			{
				JOMHEIHLLDM = other.JOMHEIHLLDM;
			}
			avatarList_.Add(other.avatarList_);
			if (other.DifficultyLevel != 0)
			{
				DifficultyLevel = other.DifficultyLevel;
			}
			if (other.LJPLIHEPGHA != 0)
			{
				LJPLIHEPGHA = other.LJPLIHEPGHA;
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
				NBDHADPNGNH = input.ReadBool();
				break;
			case 16u:
				Count = input.ReadUInt32();
				break;
			case 24u:
				JOMHEIHLLDM = input.ReadUInt32();
				break;
			case 50u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 72u:
				DifficultyLevel = input.ReadUInt32();
				break;
			case 80u:
				LJPLIHEPGHA = input.ReadUInt32();
				break;
			}
		}
	}
}
