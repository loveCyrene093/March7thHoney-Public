using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DirectDeliveryScNotify : IMessage<DirectDeliveryScNotify>, IMessage, IEquatable<DirectDeliveryScNotify>, IDeepCloneable<DirectDeliveryScNotify>, IBufferMessage
{
	private static readonly MessageParser<DirectDeliveryScNotify> _parser = new MessageParser<DirectDeliveryScNotify>(() => new DirectDeliveryScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HALFGLGLDLOFieldNumber = 1;

	private static readonly FieldCodec<ItemList> _repeated_hALFGLGLDLO_codec = FieldCodec.ForMessage(10u, ItemList.Parser);

	private readonly RepeatedField<ItemList> hALFGLGLDLO_ = new RepeatedField<ItemList>();

	public const int OECCPKANHMNFieldNumber = 9;

	private uint oECCPKANHMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DirectDeliveryScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DirectDeliveryScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemList> HALFGLGLDLO => hALFGLGLDLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OECCPKANHMN
	{
		get
		{
			return oECCPKANHMN_;
		}
		set
		{
			oECCPKANHMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DirectDeliveryScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DirectDeliveryScNotify(DirectDeliveryScNotify other)
		: this()
	{
		hALFGLGLDLO_ = other.hALFGLGLDLO_.Clone();
		oECCPKANHMN_ = other.oECCPKANHMN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DirectDeliveryScNotify Clone()
	{
		return new DirectDeliveryScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DirectDeliveryScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DirectDeliveryScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hALFGLGLDLO_.Equals(other.hALFGLGLDLO_))
		{
			return false;
		}
		if (OECCPKANHMN != other.OECCPKANHMN)
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
		num ^= hALFGLGLDLO_.GetHashCode();
		if (OECCPKANHMN != 0)
		{
			num ^= OECCPKANHMN.GetHashCode();
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
		hALFGLGLDLO_.WriteTo(ref output, _repeated_hALFGLGLDLO_codec);
		if (OECCPKANHMN != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OECCPKANHMN);
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
		num += hALFGLGLDLO_.CalculateSize(_repeated_hALFGLGLDLO_codec);
		if (OECCPKANHMN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OECCPKANHMN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DirectDeliveryScNotify other)
	{
		if (other != null)
		{
			hALFGLGLDLO_.Add(other.hALFGLGLDLO_);
			if (other.OECCPKANHMN != 0)
			{
				OECCPKANHMN = other.OECCPKANHMN;
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
			case 10u:
				hALFGLGLDLO_.AddEntriesFrom(ref input, _repeated_hALFGLGLDLO_codec);
				break;
			case 72u:
				OECCPKANHMN = input.ReadUInt32();
				break;
			}
		}
	}
}
