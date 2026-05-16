using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateAllowedSelectCellScNotify : IMessage<ChessRogueUpdateAllowedSelectCellScNotify>, IMessage, IEquatable<ChessRogueUpdateAllowedSelectCellScNotify>, IDeepCloneable<ChessRogueUpdateAllowedSelectCellScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateAllowedSelectCellScNotify> _parser = new MessageParser<ChessRogueUpdateAllowedSelectCellScNotify>(() => new ChessRogueUpdateAllowedSelectCellScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PNEMJFMGKJJFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_pNEMJFMGKJJ_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> pNEMJFMGKJJ_ = new RepeatedField<uint>();

	public const int OHHGAAKGLDOFieldNumber = 14;

	private uint oHHGAAKGLDO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateAllowedSelectCellScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateAllowedSelectCellScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PNEMJFMGKJJ => pNEMJFMGKJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OHHGAAKGLDO
	{
		get
		{
			return oHHGAAKGLDO_;
		}
		set
		{
			oHHGAAKGLDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateAllowedSelectCellScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateAllowedSelectCellScNotify(ChessRogueUpdateAllowedSelectCellScNotify other)
		: this()
	{
		pNEMJFMGKJJ_ = other.pNEMJFMGKJJ_.Clone();
		oHHGAAKGLDO_ = other.oHHGAAKGLDO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateAllowedSelectCellScNotify Clone()
	{
		return new ChessRogueUpdateAllowedSelectCellScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateAllowedSelectCellScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateAllowedSelectCellScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pNEMJFMGKJJ_.Equals(other.pNEMJFMGKJJ_))
		{
			return false;
		}
		if (OHHGAAKGLDO != other.OHHGAAKGLDO)
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
		num ^= pNEMJFMGKJJ_.GetHashCode();
		if (OHHGAAKGLDO != 0)
		{
			num ^= OHHGAAKGLDO.GetHashCode();
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
		pNEMJFMGKJJ_.WriteTo(ref output, _repeated_pNEMJFMGKJJ_codec);
		if (OHHGAAKGLDO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OHHGAAKGLDO);
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
		num += pNEMJFMGKJJ_.CalculateSize(_repeated_pNEMJFMGKJJ_codec);
		if (OHHGAAKGLDO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OHHGAAKGLDO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateAllowedSelectCellScNotify other)
	{
		if (other != null)
		{
			pNEMJFMGKJJ_.Add(other.pNEMJFMGKJJ_);
			if (other.OHHGAAKGLDO != 0)
			{
				OHHGAAKGLDO = other.OHHGAAKGLDO;
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
			case 42u:
				pNEMJFMGKJJ_.AddEntriesFrom(ref input, _repeated_pNEMJFMGKJJ_codec);
				break;
			case 112u:
				OHHGAAKGLDO = input.ReadUInt32();
				break;
			}
		}
	}
}
