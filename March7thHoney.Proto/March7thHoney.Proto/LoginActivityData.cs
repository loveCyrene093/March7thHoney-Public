using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LoginActivityData : IMessage<LoginActivityData>, IMessage, IEquatable<LoginActivityData>, IDeepCloneable<LoginActivityData>, IBufferMessage
{
	private static readonly MessageParser<LoginActivityData> _parser = new MessageParser<LoginActivityData>(() => new LoginActivityData());

	private UnknownFieldSet _unknownFields;

	public const int EKNCPHDGBMNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_eKNCPHDGBMN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> eKNCPHDGBMN_ = new RepeatedField<uint>();

	public const int IdFieldNumber = 12;

	private uint id_;

	public const int PanelIdFieldNumber = 14;

	private uint panelId_;

	public const int LoginDaysFieldNumber = 15;

	private uint loginDays_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LoginActivityData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LoginActivityDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EKNCPHDGBMN => eKNCPHDGBMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LoginDays
	{
		get
		{
			return loginDays_;
		}
		set
		{
			loginDays_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginActivityData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginActivityData(LoginActivityData other)
		: this()
	{
		eKNCPHDGBMN_ = other.eKNCPHDGBMN_.Clone();
		id_ = other.id_;
		panelId_ = other.panelId_;
		loginDays_ = other.loginDays_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LoginActivityData Clone()
	{
		return new LoginActivityData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LoginActivityData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LoginActivityData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eKNCPHDGBMN_.Equals(other.eKNCPHDGBMN_))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (LoginDays != other.LoginDays)
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
		num ^= eKNCPHDGBMN_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (LoginDays != 0)
		{
			num ^= LoginDays.GetHashCode();
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
		eKNCPHDGBMN_.WriteTo(ref output, _repeated_eKNCPHDGBMN_codec);
		if (Id != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Id);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PanelId);
		}
		if (LoginDays != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LoginDays);
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
		num += eKNCPHDGBMN_.CalculateSize(_repeated_eKNCPHDGBMN_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (LoginDays != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LoginDays);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LoginActivityData other)
	{
		if (other != null)
		{
			eKNCPHDGBMN_.Add(other.eKNCPHDGBMN_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.LoginDays != 0)
			{
				LoginDays = other.LoginDays;
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
			case 56u:
			case 58u:
				eKNCPHDGBMN_.AddEntriesFrom(ref input, _repeated_eKNCPHDGBMN_codec);
				break;
			case 96u:
				Id = input.ReadUInt32();
				break;
			case 112u:
				PanelId = input.ReadUInt32();
				break;
			case 120u:
				LoginDays = input.ReadUInt32();
				break;
			}
		}
	}
}
