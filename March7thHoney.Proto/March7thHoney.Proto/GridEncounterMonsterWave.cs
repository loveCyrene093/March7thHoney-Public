using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridEncounterMonsterWave : IMessage<GridEncounterMonsterWave>, IMessage, IEquatable<GridEncounterMonsterWave>, IDeepCloneable<GridEncounterMonsterWave>, IBufferMessage
{
	private static readonly MessageParser<GridEncounterMonsterWave> _parser = new MessageParser<GridEncounterMonsterWave>(() => new GridEncounterMonsterWave());

	private UnknownFieldSet _unknownFields;

	public const int IGMMPDDCJINFieldNumber = 1;

	private uint iGMMPDDCJIN_;

	public const int PPOEDDFFEKKFieldNumber = 4;

	private static readonly FieldCodec<PJLBDMPEKFP> _repeated_pPOEDDFFEKK_codec = FieldCodec.ForMessage(34u, PJLBDMPEKFP.Parser);

	private readonly RepeatedField<PJLBDMPEKFP> pPOEDDFFEKK_ = new RepeatedField<PJLBDMPEKFP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridEncounterMonsterWave> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridEncounterMonsterWaveReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGMMPDDCJIN
	{
		get
		{
			return iGMMPDDCJIN_;
		}
		set
		{
			iGMMPDDCJIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PJLBDMPEKFP> PPOEDDFFEKK => pPOEDDFFEKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridEncounterMonsterWave()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridEncounterMonsterWave(GridEncounterMonsterWave other)
		: this()
	{
		iGMMPDDCJIN_ = other.iGMMPDDCJIN_;
		pPOEDDFFEKK_ = other.pPOEDDFFEKK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridEncounterMonsterWave Clone()
	{
		return new GridEncounterMonsterWave(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridEncounterMonsterWave);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridEncounterMonsterWave other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGMMPDDCJIN != other.IGMMPDDCJIN)
		{
			return false;
		}
		if (!pPOEDDFFEKK_.Equals(other.pPOEDDFFEKK_))
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
		if (IGMMPDDCJIN != 0)
		{
			num ^= IGMMPDDCJIN.GetHashCode();
		}
		num ^= pPOEDDFFEKK_.GetHashCode();
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
		if (IGMMPDDCJIN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IGMMPDDCJIN);
		}
		pPOEDDFFEKK_.WriteTo(ref output, _repeated_pPOEDDFFEKK_codec);
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
		if (IGMMPDDCJIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGMMPDDCJIN);
		}
		num += pPOEDDFFEKK_.CalculateSize(_repeated_pPOEDDFFEKK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridEncounterMonsterWave other)
	{
		if (other != null)
		{
			if (other.IGMMPDDCJIN != 0)
			{
				IGMMPDDCJIN = other.IGMMPDDCJIN;
			}
			pPOEDDFFEKK_.Add(other.pPOEDDFFEKK_);
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
				IGMMPDDCJIN = input.ReadUInt32();
				break;
			case 34u:
				pPOEDDFFEKK_.AddEntriesFrom(ref input, _repeated_pPOEDDFFEKK_codec);
				break;
			}
		}
	}
}
