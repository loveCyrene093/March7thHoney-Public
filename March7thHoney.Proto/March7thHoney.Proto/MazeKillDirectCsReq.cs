using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MazeKillDirectCsReq : IMessage<MazeKillDirectCsReq>, IMessage, IEquatable<MazeKillDirectCsReq>, IDeepCloneable<MazeKillDirectCsReq>, IBufferMessage
{
	private static readonly MessageParser<MazeKillDirectCsReq> _parser = new MessageParser<MazeKillDirectCsReq>(() => new MazeKillDirectCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EntityListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_entityList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> entityList_ = new RepeatedField<uint>();

	public const int GJKGPDHNKHEFieldNumber = 8;

	private uint gJKGPDHNKHE_;

	public const int ALFHNEHOBJAFieldNumber = 9;

	private EBKOLHJIOFN aLFHNEHOBJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MazeKillDirectCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MazeKillDirectCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EntityList => entityList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJKGPDHNKHE
	{
		get
		{
			return gJKGPDHNKHE_;
		}
		set
		{
			gJKGPDHNKHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBKOLHJIOFN ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeKillDirectCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeKillDirectCsReq(MazeKillDirectCsReq other)
		: this()
	{
		entityList_ = other.entityList_.Clone();
		gJKGPDHNKHE_ = other.gJKGPDHNKHE_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeKillDirectCsReq Clone()
	{
		return new MazeKillDirectCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MazeKillDirectCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MazeKillDirectCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!entityList_.Equals(other.entityList_))
		{
			return false;
		}
		if (GJKGPDHNKHE != other.GJKGPDHNKHE)
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
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
		num ^= entityList_.GetHashCode();
		if (GJKGPDHNKHE != 0)
		{
			num ^= GJKGPDHNKHE.GetHashCode();
		}
		if (ALFHNEHOBJA != EBKOLHJIOFN.Bflaajpjiea)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
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
		entityList_.WriteTo(ref output, _repeated_entityList_codec);
		if (GJKGPDHNKHE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GJKGPDHNKHE);
		}
		if (ALFHNEHOBJA != EBKOLHJIOFN.Bflaajpjiea)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)ALFHNEHOBJA);
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
		num += entityList_.CalculateSize(_repeated_entityList_codec);
		if (GJKGPDHNKHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJKGPDHNKHE);
		}
		if (ALFHNEHOBJA != EBKOLHJIOFN.Bflaajpjiea)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MazeKillDirectCsReq other)
	{
		if (other != null)
		{
			entityList_.Add(other.entityList_);
			if (other.GJKGPDHNKHE != 0)
			{
				GJKGPDHNKHE = other.GJKGPDHNKHE;
			}
			if (other.ALFHNEHOBJA != EBKOLHJIOFN.Bflaajpjiea)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
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
			case 32u:
			case 34u:
				entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
				break;
			case 64u:
				GJKGPDHNKHE = input.ReadUInt32();
				break;
			case 72u:
				ALFHNEHOBJA = (EBKOLHJIOFN)input.ReadEnum();
				break;
			}
		}
	}
}
