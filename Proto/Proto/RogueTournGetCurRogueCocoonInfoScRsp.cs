using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournGetCurRogueCocoonInfoScRsp : IMessage<RogueTournGetCurRogueCocoonInfoScRsp>, IMessage, IEquatable<RogueTournGetCurRogueCocoonInfoScRsp>, IDeepCloneable<RogueTournGetCurRogueCocoonInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournGetCurRogueCocoonInfoScRsp> _parser = new MessageParser<RogueTournGetCurRogueCocoonInfoScRsp>(() => new RogueTournGetCurRogueCocoonInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CountFieldNumber = 3;

	private uint count_;

	public const int LJPLIHEPGHAFieldNumber = 4;

	private uint lJPLIHEPGHA_;

	public const int DifficultyLevelFieldNumber = 5;

	private uint difficultyLevel_;

	public const int JOMHEIHLLDMFieldNumber = 9;

	private uint jOMHEIHLLDM_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournGetCurRogueCocoonInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournGetCurRogueCocoonInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RogueTournGetCurRogueCocoonInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetCurRogueCocoonInfoScRsp(RogueTournGetCurRogueCocoonInfoScRsp other)
		: this()
	{
		count_ = other.count_;
		lJPLIHEPGHA_ = other.lJPLIHEPGHA_;
		difficultyLevel_ = other.difficultyLevel_;
		jOMHEIHLLDM_ = other.jOMHEIHLLDM_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetCurRogueCocoonInfoScRsp Clone()
	{
		return new RogueTournGetCurRogueCocoonInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournGetCurRogueCocoonInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournGetCurRogueCocoonInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (LJPLIHEPGHA != other.LJPLIHEPGHA)
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (JOMHEIHLLDM != other.JOMHEIHLLDM)
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (LJPLIHEPGHA != 0)
		{
			num ^= LJPLIHEPGHA.GetHashCode();
		}
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (JOMHEIHLLDM != 0)
		{
			num ^= JOMHEIHLLDM.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Count);
		}
		if (LJPLIHEPGHA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LJPLIHEPGHA);
		}
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DifficultyLevel);
		}
		if (JOMHEIHLLDM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(JOMHEIHLLDM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (LJPLIHEPGHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJPLIHEPGHA);
		}
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (JOMHEIHLLDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JOMHEIHLLDM);
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
	public void MergeFrom(RogueTournGetCurRogueCocoonInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.LJPLIHEPGHA != 0)
			{
				LJPLIHEPGHA = other.LJPLIHEPGHA;
			}
			if (other.DifficultyLevel != 0)
			{
				DifficultyLevel = other.DifficultyLevel;
			}
			if (other.JOMHEIHLLDM != 0)
			{
				JOMHEIHLLDM = other.JOMHEIHLLDM;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 24u:
				Count = input.ReadUInt32();
				break;
			case 32u:
				LJPLIHEPGHA = input.ReadUInt32();
				break;
			case 40u:
				DifficultyLevel = input.ReadUInt32();
				break;
			case 72u:
				JOMHEIHLLDM = input.ReadUInt32();
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
