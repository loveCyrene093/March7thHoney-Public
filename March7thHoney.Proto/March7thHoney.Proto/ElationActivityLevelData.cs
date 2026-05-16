using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElationActivityLevelData : IMessage<ElationActivityLevelData>, IMessage, IEquatable<ElationActivityLevelData>, IDeepCloneable<ElationActivityLevelData>, IBufferMessage
{
	private static readonly MessageParser<ElationActivityLevelData> _parser = new MessageParser<ElationActivityLevelData>(() => new ElationActivityLevelData());

	private UnknownFieldSet _unknownFields;

	public const int LevelIdFieldNumber = 1;

	private uint levelId_;

	public const int BLENMGJDKEPFieldNumber = 2;

	private uint bLENMGJDKEP_;

	public const int DHPHLCHPKFLFieldNumber = 7;

	private uint dHPHLCHPKFL_;

	public const int IsPerfectFieldNumber = 11;

	private bool isPerfect_;

	public const int OJOIJEGNFEOFieldNumber = 13;

	private uint oJOIJEGNFEO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElationActivityLevelData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElationActivityLevelDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint BLENMGJDKEP
	{
		get
		{
			return bLENMGJDKEP_;
		}
		set
		{
			bLENMGJDKEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHPHLCHPKFL
	{
		get
		{
			return dHPHLCHPKFL_;
		}
		set
		{
			dHPHLCHPKFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPerfect
	{
		get
		{
			return isPerfect_;
		}
		set
		{
			isPerfect_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OJOIJEGNFEO
	{
		get
		{
			return oJOIJEGNFEO_;
		}
		set
		{
			oJOIJEGNFEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityLevelData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityLevelData(ElationActivityLevelData other)
		: this()
	{
		levelId_ = other.levelId_;
		bLENMGJDKEP_ = other.bLENMGJDKEP_;
		dHPHLCHPKFL_ = other.dHPHLCHPKFL_;
		isPerfect_ = other.isPerfect_;
		oJOIJEGNFEO_ = other.oJOIJEGNFEO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElationActivityLevelData Clone()
	{
		return new ElationActivityLevelData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElationActivityLevelData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElationActivityLevelData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (BLENMGJDKEP != other.BLENMGJDKEP)
		{
			return false;
		}
		if (DHPHLCHPKFL != other.DHPHLCHPKFL)
		{
			return false;
		}
		if (IsPerfect != other.IsPerfect)
		{
			return false;
		}
		if (OJOIJEGNFEO != other.OJOIJEGNFEO)
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
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (BLENMGJDKEP != 0)
		{
			num ^= BLENMGJDKEP.GetHashCode();
		}
		if (DHPHLCHPKFL != 0)
		{
			num ^= DHPHLCHPKFL.GetHashCode();
		}
		if (IsPerfect)
		{
			num ^= IsPerfect.GetHashCode();
		}
		if (OJOIJEGNFEO != 0)
		{
			num ^= OJOIJEGNFEO.GetHashCode();
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
		if (LevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LevelId);
		}
		if (BLENMGJDKEP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BLENMGJDKEP);
		}
		if (DHPHLCHPKFL != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DHPHLCHPKFL);
		}
		if (IsPerfect)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsPerfect);
		}
		if (OJOIJEGNFEO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OJOIJEGNFEO);
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
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (BLENMGJDKEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BLENMGJDKEP);
		}
		if (DHPHLCHPKFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHPHLCHPKFL);
		}
		if (IsPerfect)
		{
			num += 2;
		}
		if (OJOIJEGNFEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OJOIJEGNFEO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ElationActivityLevelData other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.BLENMGJDKEP != 0)
			{
				BLENMGJDKEP = other.BLENMGJDKEP;
			}
			if (other.DHPHLCHPKFL != 0)
			{
				DHPHLCHPKFL = other.DHPHLCHPKFL;
			}
			if (other.IsPerfect)
			{
				IsPerfect = other.IsPerfect;
			}
			if (other.OJOIJEGNFEO != 0)
			{
				OJOIJEGNFEO = other.OJOIJEGNFEO;
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
				LevelId = input.ReadUInt32();
				break;
			case 16u:
				BLENMGJDKEP = input.ReadUInt32();
				break;
			case 56u:
				DHPHLCHPKFL = input.ReadUInt32();
				break;
			case 88u:
				IsPerfect = input.ReadBool();
				break;
			case 104u:
				OJOIJEGNFEO = input.ReadUInt32();
				break;
			}
		}
	}
}
