using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightUpdateEquipTrackCsReq : IMessage<GridFightUpdateEquipTrackCsReq>, IMessage, IEquatable<GridFightUpdateEquipTrackCsReq>, IDeepCloneable<GridFightUpdateEquipTrackCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightUpdateEquipTrackCsReq> _parser = new MessageParser<GridFightUpdateEquipTrackCsReq>(() => new GridFightUpdateEquipTrackCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BEPEKLPAHMCFieldNumber = 3;

	private static readonly FieldCodec<DFKGECLBCDK> _repeated_bEPEKLPAHMC_codec = FieldCodec.ForMessage(26u, DFKGECLBCDK.Parser);

	private readonly RepeatedField<DFKGECLBCDK> bEPEKLPAHMC_ = new RepeatedField<DFKGECLBCDK>();

	public const int SourceFieldNumber = 15;

	private GridFightEquipTrackSource source_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightUpdateEquipTrackCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightUpdateEquipTrackCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DFKGECLBCDK> BEPEKLPAHMC => bEPEKLPAHMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipTrackSource Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateEquipTrackCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateEquipTrackCsReq(GridFightUpdateEquipTrackCsReq other)
		: this()
	{
		bEPEKLPAHMC_ = other.bEPEKLPAHMC_.Clone();
		source_ = other.source_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateEquipTrackCsReq Clone()
	{
		return new GridFightUpdateEquipTrackCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightUpdateEquipTrackCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightUpdateEquipTrackCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bEPEKLPAHMC_.Equals(other.bEPEKLPAHMC_))
		{
			return false;
		}
		if (Source != other.Source)
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
		num ^= bEPEKLPAHMC_.GetHashCode();
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			num ^= Source.GetHashCode();
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
		bEPEKLPAHMC_.WriteTo(ref output, _repeated_bEPEKLPAHMC_codec);
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)Source);
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
		num += bEPEKLPAHMC_.CalculateSize(_repeated_bEPEKLPAHMC_codec);
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightUpdateEquipTrackCsReq other)
	{
		if (other != null)
		{
			bEPEKLPAHMC_.Add(other.bEPEKLPAHMC_);
			if (other.Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
			{
				Source = other.Source;
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
			case 26u:
				bEPEKLPAHMC_.AddEntriesFrom(ref input, _repeated_bEPEKLPAHMC_codec);
				break;
			case 120u:
				Source = (GridFightEquipTrackSource)input.ReadEnum();
				break;
			}
		}
	}
}
