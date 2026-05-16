using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NDCJAAOLEBA : IMessage<NDCJAAOLEBA>, IMessage, IEquatable<NDCJAAOLEBA>, IDeepCloneable<NDCJAAOLEBA>, IBufferMessage
{
	private static readonly MessageParser<NDCJAAOLEBA> _parser = new MessageParser<NDCJAAOLEBA>(() => new NDCJAAOLEBA());

	private UnknownFieldSet _unknownFields;

	public const int BBJCMOFGBFIFieldNumber = 7;

	private static readonly MapField<uint, double>.Codec _map_bBJCMOFGBFI_codec = new MapField<uint, double>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForDouble(17u, 0.0), 58u);

	private readonly MapField<uint, double> bBJCMOFGBFI_ = new MapField<uint, double>();

	public const int SourceFieldNumber = 9;

	private APHLJPLBOIF source_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NDCJAAOLEBA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NDCJAAOLEBAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, double> BBJCMOFGBFI => bBJCMOFGBFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHLJPLBOIF Source
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
	public NDCJAAOLEBA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDCJAAOLEBA(NDCJAAOLEBA other)
		: this()
	{
		bBJCMOFGBFI_ = other.bBJCMOFGBFI_.Clone();
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDCJAAOLEBA Clone()
	{
		return new NDCJAAOLEBA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NDCJAAOLEBA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NDCJAAOLEBA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!BBJCMOFGBFI.Equals(other.BBJCMOFGBFI))
		{
			return false;
		}
		if (!object.Equals(Source, other.Source))
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
		num ^= BBJCMOFGBFI.GetHashCode();
		if (source_ != null)
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
		bBJCMOFGBFI_.WriteTo(ref output, _map_bBJCMOFGBFI_codec);
		if (source_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Source);
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
		num += bBJCMOFGBFI_.CalculateSize(_map_bBJCMOFGBFI_codec);
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NDCJAAOLEBA other)
	{
		if (other == null)
		{
			return;
		}
		bBJCMOFGBFI_.MergeFrom(other.bBJCMOFGBFI_);
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new APHLJPLBOIF();
			}
			Source.MergeFrom(other.Source);
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
			case 58u:
				bBJCMOFGBFI_.AddEntriesFrom(ref input, _map_bBJCMOFGBFI_codec);
				break;
			case 74u:
				if (source_ == null)
				{
					Source = new APHLJPLBOIF();
				}
				input.ReadMessage(Source);
				break;
			}
		}
	}
}
