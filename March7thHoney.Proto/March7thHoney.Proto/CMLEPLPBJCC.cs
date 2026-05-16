using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CMLEPLPBJCC : IMessage<CMLEPLPBJCC>, IMessage, IEquatable<CMLEPLPBJCC>, IDeepCloneable<CMLEPLPBJCC>, IBufferMessage
{
	private static readonly MessageParser<CMLEPLPBJCC> _parser = new MessageParser<CMLEPLPBJCC>(() => new CMLEPLPBJCC());

	private UnknownFieldSet _unknownFields;

	public const int FGOCDCMKDMLFieldNumber = 6;

	private static readonly FieldCodec<ABHILGFLJNO> _repeated_fGOCDCMKDML_codec = FieldCodec.ForMessage(50u, ABHILGFLJNO.Parser);

	private readonly RepeatedField<ABHILGFLJNO> fGOCDCMKDML_ = new RepeatedField<ABHILGFLJNO>();

	public const int FloorIdFieldNumber = 8;

	private uint floorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CMLEPLPBJCC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CMLEPLPBJCCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ABHILGFLJNO> FGOCDCMKDML => fGOCDCMKDML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMLEPLPBJCC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMLEPLPBJCC(CMLEPLPBJCC other)
		: this()
	{
		fGOCDCMKDML_ = other.fGOCDCMKDML_.Clone();
		floorId_ = other.floorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMLEPLPBJCC Clone()
	{
		return new CMLEPLPBJCC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CMLEPLPBJCC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CMLEPLPBJCC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fGOCDCMKDML_.Equals(other.fGOCDCMKDML_))
		{
			return false;
		}
		if (FloorId != other.FloorId)
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
		num ^= fGOCDCMKDML_.GetHashCode();
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
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
		fGOCDCMKDML_.WriteTo(ref output, _repeated_fGOCDCMKDML_codec);
		if (FloorId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FloorId);
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
		num += fGOCDCMKDML_.CalculateSize(_repeated_fGOCDCMKDML_codec);
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CMLEPLPBJCC other)
	{
		if (other != null)
		{
			fGOCDCMKDML_.Add(other.fGOCDCMKDML_);
			if (other.FloorId != 0)
			{
				FloorId = other.FloorId;
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
			case 50u:
				fGOCDCMKDML_.AddEntriesFrom(ref input, _repeated_fGOCDCMKDML_codec);
				break;
			case 64u:
				FloorId = input.ReadUInt32();
				break;
			}
		}
	}
}
