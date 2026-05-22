using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpringRecoverConfig : IMessage<SpringRecoverConfig>, IMessage, IEquatable<SpringRecoverConfig>, IDeepCloneable<SpringRecoverConfig>, IBufferMessage
{
	private static readonly MessageParser<SpringRecoverConfig> _parser = new MessageParser<SpringRecoverConfig>(() => new SpringRecoverConfig());

	private UnknownFieldSet _unknownFields;

	public const int BJJMAHMKONCFieldNumber = 4;

	private uint bJJMAHMKONC_;

	public const int FOHMBNJNLKFFieldNumber = 9;

	private static readonly FieldCodec<AvatarPresetHp> _repeated_fOHMBNJNLKF_codec = FieldCodec.ForMessage(74u, AvatarPresetHp.Parser);

	private readonly RepeatedField<AvatarPresetHp> fOHMBNJNLKF_ = new RepeatedField<AvatarPresetHp>();

	public const int CACHECAODENFieldNumber = 10;

	private bool cACHECAODEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpringRecoverConfig> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpringRecoverConfigReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BJJMAHMKONC
	{
		get
		{
			return bJJMAHMKONC_;
		}
		set
		{
			bJJMAHMKONC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarPresetHp> FOHMBNJNLKF => fOHMBNJNLKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CACHECAODEN
	{
		get
		{
			return cACHECAODEN_;
		}
		set
		{
			cACHECAODEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpringRecoverConfig()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpringRecoverConfig(SpringRecoverConfig other)
		: this()
	{
		bJJMAHMKONC_ = other.bJJMAHMKONC_;
		fOHMBNJNLKF_ = other.fOHMBNJNLKF_.Clone();
		cACHECAODEN_ = other.cACHECAODEN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpringRecoverConfig Clone()
	{
		return new SpringRecoverConfig(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpringRecoverConfig);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpringRecoverConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BJJMAHMKONC != other.BJJMAHMKONC)
		{
			return false;
		}
		if (!fOHMBNJNLKF_.Equals(other.fOHMBNJNLKF_))
		{
			return false;
		}
		if (CACHECAODEN != other.CACHECAODEN)
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
		if (BJJMAHMKONC != 0)
		{
			num ^= BJJMAHMKONC.GetHashCode();
		}
		num ^= fOHMBNJNLKF_.GetHashCode();
		if (CACHECAODEN)
		{
			num ^= CACHECAODEN.GetHashCode();
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
		if (BJJMAHMKONC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BJJMAHMKONC);
		}
		fOHMBNJNLKF_.WriteTo(ref output, _repeated_fOHMBNJNLKF_codec);
		if (CACHECAODEN)
		{
			output.WriteRawTag(80);
			output.WriteBool(CACHECAODEN);
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
		if (BJJMAHMKONC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BJJMAHMKONC);
		}
		num += fOHMBNJNLKF_.CalculateSize(_repeated_fOHMBNJNLKF_codec);
		if (CACHECAODEN)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpringRecoverConfig other)
	{
		if (other != null)
		{
			if (other.BJJMAHMKONC != 0)
			{
				BJJMAHMKONC = other.BJJMAHMKONC;
			}
			fOHMBNJNLKF_.Add(other.fOHMBNJNLKF_);
			if (other.CACHECAODEN)
			{
				CACHECAODEN = other.CACHECAODEN;
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
			case 32u:
				BJJMAHMKONC = input.ReadUInt32();
				break;
			case 74u:
				fOHMBNJNLKF_.AddEntriesFrom(ref input, _repeated_fOHMBNJNLKF_codec);
				break;
			case 80u:
				CACHECAODEN = input.ReadBool();
				break;
			}
		}
	}
}
