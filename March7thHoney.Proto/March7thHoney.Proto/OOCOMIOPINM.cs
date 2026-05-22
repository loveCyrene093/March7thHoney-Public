using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOCOMIOPINM : IMessage<OOCOMIOPINM>, IMessage, IEquatable<OOCOMIOPINM>, IDeepCloneable<OOCOMIOPINM>, IBufferMessage
{
	private static readonly MessageParser<OOCOMIOPINM> _parser = new MessageParser<OOCOMIOPINM>(() => new OOCOMIOPINM());

	private UnknownFieldSet _unknownFields;

	public const int InteractedPropEntityIdFieldNumber = 6;

	private uint interactedPropEntityId_;

	public const int DCBJNILFBAGFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dCBJNILFBAG_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dCBJNILFBAG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOCOMIOPINM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOCOMIOPINMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractedPropEntityId
	{
		get
		{
			return interactedPropEntityId_;
		}
		set
		{
			interactedPropEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DCBJNILFBAG => dCBJNILFBAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOCOMIOPINM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOCOMIOPINM(OOCOMIOPINM other)
		: this()
	{
		interactedPropEntityId_ = other.interactedPropEntityId_;
		dCBJNILFBAG_ = other.dCBJNILFBAG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOCOMIOPINM Clone()
	{
		return new OOCOMIOPINM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOCOMIOPINM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOCOMIOPINM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractedPropEntityId != other.InteractedPropEntityId)
		{
			return false;
		}
		if (!dCBJNILFBAG_.Equals(other.dCBJNILFBAG_))
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
		if (InteractedPropEntityId != 0)
		{
			num ^= InteractedPropEntityId.GetHashCode();
		}
		num ^= dCBJNILFBAG_.GetHashCode();
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
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(InteractedPropEntityId);
		}
		dCBJNILFBAG_.WriteTo(ref output, _repeated_dCBJNILFBAG_codec);
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
		if (InteractedPropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractedPropEntityId);
		}
		num += dCBJNILFBAG_.CalculateSize(_repeated_dCBJNILFBAG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOCOMIOPINM other)
	{
		if (other != null)
		{
			if (other.InteractedPropEntityId != 0)
			{
				InteractedPropEntityId = other.InteractedPropEntityId;
			}
			dCBJNILFBAG_.Add(other.dCBJNILFBAG_);
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
			case 48u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				dCBJNILFBAG_.AddEntriesFrom(ref input, _repeated_dCBJNILFBAG_codec);
				break;
			}
		}
	}
}
