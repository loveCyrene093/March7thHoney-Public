using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IGFHFBAFDDO : IMessage<IGFHFBAFDDO>, IMessage, IEquatable<IGFHFBAFDDO>, IDeepCloneable<IGFHFBAFDDO>, IBufferMessage
{
	private static readonly MessageParser<IGFHFBAFDDO> _parser = new MessageParser<IGFHFBAFDDO>(() => new IGFHFBAFDDO());

	private UnknownFieldSet _unknownFields;

	public const int GOKCEADOFBCFieldNumber = 13;

	private static readonly FieldCodec<GLHDNGFKAAD> _repeated_gOKCEADOFBC_codec = FieldCodec.ForMessage(106u, GLHDNGFKAAD.Parser);

	private readonly RepeatedField<GLHDNGFKAAD> gOKCEADOFBC_ = new RepeatedField<GLHDNGFKAAD>();

	public const int ShopIdFieldNumber = 15;

	private uint shopId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IGFHFBAFDDO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IGFHFBAFDDOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GLHDNGFKAAD> GOKCEADOFBC => gOKCEADOFBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGFHFBAFDDO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGFHFBAFDDO(IGFHFBAFDDO other)
		: this()
	{
		gOKCEADOFBC_ = other.gOKCEADOFBC_.Clone();
		shopId_ = other.shopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGFHFBAFDDO Clone()
	{
		return new IGFHFBAFDDO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IGFHFBAFDDO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IGFHFBAFDDO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gOKCEADOFBC_.Equals(other.gOKCEADOFBC_))
		{
			return false;
		}
		if (ShopId != other.ShopId)
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
		num ^= gOKCEADOFBC_.GetHashCode();
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
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
		gOKCEADOFBC_.WriteTo(ref output, _repeated_gOKCEADOFBC_codec);
		if (ShopId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ShopId);
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
		num += gOKCEADOFBC_.CalculateSize(_repeated_gOKCEADOFBC_codec);
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IGFHFBAFDDO other)
	{
		if (other != null)
		{
			gOKCEADOFBC_.Add(other.gOKCEADOFBC_);
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
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
			case 106u:
				gOKCEADOFBC_.AddEntriesFrom(ref input, _repeated_gOKCEADOFBC_codec);
				break;
			case 120u:
				ShopId = input.ReadUInt32();
				break;
			}
		}
	}
}
