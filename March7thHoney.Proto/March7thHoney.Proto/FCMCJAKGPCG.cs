using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FCMCJAKGPCG : IMessage<FCMCJAKGPCG>, IMessage, IEquatable<FCMCJAKGPCG>, IDeepCloneable<FCMCJAKGPCG>, IBufferMessage
{
	private static readonly MessageParser<FCMCJAKGPCG> _parser = new MessageParser<FCMCJAKGPCG>(() => new FCMCJAKGPCG());

	private UnknownFieldSet _unknownFields;

	public const int PPEBFAJJENGFieldNumber = 1;

	private uint pPEBFAJJENG_;

	public const int LJHNNBFBMJJFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_lJHNNBFBMJJ_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> lJHNNBFBMJJ_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FCMCJAKGPCG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FCMCJAKGPCGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPEBFAJJENG
	{
		get
		{
			return pPEBFAJJENG_;
		}
		set
		{
			pPEBFAJJENG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LJHNNBFBMJJ => lJHNNBFBMJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCMCJAKGPCG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCMCJAKGPCG(FCMCJAKGPCG other)
		: this()
	{
		pPEBFAJJENG_ = other.pPEBFAJJENG_;
		lJHNNBFBMJJ_ = other.lJHNNBFBMJJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCMCJAKGPCG Clone()
	{
		return new FCMCJAKGPCG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FCMCJAKGPCG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FCMCJAKGPCG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PPEBFAJJENG != other.PPEBFAJJENG)
		{
			return false;
		}
		if (!lJHNNBFBMJJ_.Equals(other.lJHNNBFBMJJ_))
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
		if (PPEBFAJJENG != 0)
		{
			num ^= PPEBFAJJENG.GetHashCode();
		}
		num ^= lJHNNBFBMJJ_.GetHashCode();
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
		if (PPEBFAJJENG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PPEBFAJJENG);
		}
		lJHNNBFBMJJ_.WriteTo(ref output, _repeated_lJHNNBFBMJJ_codec);
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
		if (PPEBFAJJENG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPEBFAJJENG);
		}
		num += lJHNNBFBMJJ_.CalculateSize(_repeated_lJHNNBFBMJJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FCMCJAKGPCG other)
	{
		if (other != null)
		{
			if (other.PPEBFAJJENG != 0)
			{
				PPEBFAJJENG = other.PPEBFAJJENG;
			}
			lJHNNBFBMJJ_.Add(other.lJHNNBFBMJJ_);
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
				PPEBFAJJENG = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				lJHNNBFBMJJ_.AddEntriesFrom(ref input, _repeated_lJHNNBFBMJJ_codec);
				break;
			}
		}
	}
}
