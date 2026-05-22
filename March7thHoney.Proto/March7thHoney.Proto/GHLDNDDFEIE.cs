using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GHLDNDDFEIE : IMessage<GHLDNDDFEIE>, IMessage, IEquatable<GHLDNDDFEIE>, IDeepCloneable<GHLDNDDFEIE>, IBufferMessage
{
	private static readonly MessageParser<GHLDNDDFEIE> _parser = new MessageParser<GHLDNDDFEIE>(() => new GHLDNDDFEIE());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 1;

	private uint areaId_;

	public const int VerifyStepIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_verifyStepIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> verifyStepIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GHLDNDDFEIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GHLDNDDFEIEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> VerifyStepIdList => verifyStepIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHLDNDDFEIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHLDNDDFEIE(GHLDNDDFEIE other)
		: this()
	{
		areaId_ = other.areaId_;
		verifyStepIdList_ = other.verifyStepIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHLDNDDFEIE Clone()
	{
		return new GHLDNDDFEIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GHLDNDDFEIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GHLDNDDFEIE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!verifyStepIdList_.Equals(other.verifyStepIdList_))
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= verifyStepIdList_.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AreaId);
		}
		verifyStepIdList_.WriteTo(ref output, _repeated_verifyStepIdList_codec);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += verifyStepIdList_.CalculateSize(_repeated_verifyStepIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GHLDNDDFEIE other)
	{
		if (other != null)
		{
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			verifyStepIdList_.Add(other.verifyStepIdList_);
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
				AreaId = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				verifyStepIdList_.AddEntriesFrom(ref input, _repeated_verifyStepIdList_codec);
				break;
			}
		}
	}
}
