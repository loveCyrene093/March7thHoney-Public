using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AGAOJNNBALA : IMessage<AGAOJNNBALA>, IMessage, IEquatable<AGAOJNNBALA>, IDeepCloneable<AGAOJNNBALA>, IBufferMessage
{
	private static readonly MessageParser<AGAOJNNBALA> _parser = new MessageParser<AGAOJNNBALA>(() => new AGAOJNNBALA());

	private UnknownFieldSet _unknownFields;

	public const int GPONJAAPOMNFieldNumber = 6;

	private static readonly FieldCodec<NJGDKDEDBNB> _repeated_gPONJAAPOMN_codec = FieldCodec.ForMessage(50u, NJGDKDEDBNB.Parser);

	private readonly RepeatedField<NJGDKDEDBNB> gPONJAAPOMN_ = new RepeatedField<NJGDKDEDBNB>();

	public const int SourceFieldNumber = 7;

	private OMLONGNOMAI source_;

	public const int UniqueIdFieldNumber = 9;

	private ulong uniqueId_;

	public const int ConfigIdFieldNumber = 12;

	private uint configId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AGAOJNNBALA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AGAOJNNBALAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NJGDKDEDBNB> GPONJAAPOMN => gPONJAAPOMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMLONGNOMAI Source
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
	public ulong UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGAOJNNBALA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGAOJNNBALA(AGAOJNNBALA other)
		: this()
	{
		gPONJAAPOMN_ = other.gPONJAAPOMN_.Clone();
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		uniqueId_ = other.uniqueId_;
		configId_ = other.configId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGAOJNNBALA Clone()
	{
		return new AGAOJNNBALA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AGAOJNNBALA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AGAOJNNBALA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gPONJAAPOMN_.Equals(other.gPONJAAPOMN_))
		{
			return false;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
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
		num ^= gPONJAAPOMN_.GetHashCode();
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (UniqueId != 0L)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
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
		gPONJAAPOMN_.WriteTo(ref output, _repeated_gPONJAAPOMN_codec);
		if (source_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Source);
		}
		if (UniqueId != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(UniqueId);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ConfigId);
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
		num += gPONJAAPOMN_.CalculateSize(_repeated_gPONJAAPOMN_codec);
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (UniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UniqueId);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AGAOJNNBALA other)
	{
		if (other == null)
		{
			return;
		}
		gPONJAAPOMN_.Add(other.gPONJAAPOMN_);
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new OMLONGNOMAI();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.UniqueId != 0L)
		{
			UniqueId = other.UniqueId;
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				gPONJAAPOMN_.AddEntriesFrom(ref input, _repeated_gPONJAAPOMN_codec);
				break;
			case 58u:
				if (source_ == null)
				{
					Source = new OMLONGNOMAI();
				}
				input.ReadMessage(Source);
				break;
			case 72u:
				UniqueId = input.ReadUInt64();
				break;
			case 96u:
				ConfigId = input.ReadUInt32();
				break;
			}
		}
	}
}
