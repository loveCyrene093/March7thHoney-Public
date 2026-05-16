using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GHNALAMKDLA : IMessage<GHNALAMKDLA>, IMessage, IEquatable<GHNALAMKDLA>, IDeepCloneable<GHNALAMKDLA>, IBufferMessage
{
	private static readonly MessageParser<GHNALAMKDLA> _parser = new MessageParser<GHNALAMKDLA>(() => new GHNALAMKDLA());

	private UnknownFieldSet _unknownFields;

	public const int GEIJDOBKNADFieldNumber = 5;

	private static readonly FieldCodec<OJCIJFPNPKF> _repeated_gEIJDOBKNAD_codec = FieldCodec.ForMessage(42u, OJCIJFPNPKF.Parser);

	private readonly RepeatedField<OJCIJFPNPKF> gEIJDOBKNAD_ = new RepeatedField<OJCIJFPNPKF>();

	public const int PHKAHAHLDAEFieldNumber = 9;

	private BHCMHNKONMJ pHKAHAHLDAE_;

	public const int EventIdFieldNumber = 10;

	private uint eventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GHNALAMKDLA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GHNALAMKDLAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OJCIJFPNPKF> GEIJDOBKNAD => gEIJDOBKNAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHCMHNKONMJ PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHNALAMKDLA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHNALAMKDLA(GHNALAMKDLA other)
		: this()
	{
		gEIJDOBKNAD_ = other.gEIJDOBKNAD_.Clone();
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		eventId_ = other.eventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHNALAMKDLA Clone()
	{
		return new GHNALAMKDLA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GHNALAMKDLA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GHNALAMKDLA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gEIJDOBKNAD_.Equals(other.gEIJDOBKNAD_))
		{
			return false;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
		{
			return false;
		}
		if (EventId != other.EventId)
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
		num ^= gEIJDOBKNAD_.GetHashCode();
		if (PHKAHAHLDAE != BHCMHNKONMJ.Hhgmflocefl)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
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
		gEIJDOBKNAD_.WriteTo(ref output, _repeated_gEIJDOBKNAD_codec);
		if (PHKAHAHLDAE != BHCMHNKONMJ.Hhgmflocefl)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)PHKAHAHLDAE);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EventId);
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
		num += gEIJDOBKNAD_.CalculateSize(_repeated_gEIJDOBKNAD_codec);
		if (PHKAHAHLDAE != BHCMHNKONMJ.Hhgmflocefl)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PHKAHAHLDAE);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GHNALAMKDLA other)
	{
		if (other != null)
		{
			gEIJDOBKNAD_.Add(other.gEIJDOBKNAD_);
			if (other.PHKAHAHLDAE != BHCMHNKONMJ.Hhgmflocefl)
			{
				PHKAHAHLDAE = other.PHKAHAHLDAE;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
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
			case 42u:
				gEIJDOBKNAD_.AddEntriesFrom(ref input, _repeated_gEIJDOBKNAD_codec);
				break;
			case 72u:
				PHKAHAHLDAE = (BHCMHNKONMJ)input.ReadEnum();
				break;
			case 80u:
				EventId = input.ReadUInt32();
				break;
			}
		}
	}
}
