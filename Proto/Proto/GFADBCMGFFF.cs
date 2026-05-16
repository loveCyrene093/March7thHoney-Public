using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFADBCMGFFF : IMessage<GFADBCMGFFF>, IMessage, IEquatable<GFADBCMGFFF>, IDeepCloneable<GFADBCMGFFF>, IBufferMessage
{
	private static readonly MessageParser<GFADBCMGFFF> _parser = new MessageParser<GFADBCMGFFF>(() => new GFADBCMGFFF());

	private UnknownFieldSet _unknownFields;

	public const int HBNECEELJBJFieldNumber = 3;

	private static readonly FieldCodec<KFGAPLDLHPF> _repeated_hBNECEELJBJ_codec = FieldCodec.ForMessage(26u, KFGAPLDLHPF.Parser);

	private readonly RepeatedField<KFGAPLDLHPF> hBNECEELJBJ_ = new RepeatedField<KFGAPLDLHPF>();

	public const int PanelIdFieldNumber = 13;

	private uint panelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFADBCMGFFF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFADBCMGFFFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KFGAPLDLHPF> HBNECEELJBJ => hBNECEELJBJ_;

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
	public GFADBCMGFFF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFADBCMGFFF(GFADBCMGFFF other)
		: this()
	{
		hBNECEELJBJ_ = other.hBNECEELJBJ_.Clone();
		panelId_ = other.panelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFADBCMGFFF Clone()
	{
		return new GFADBCMGFFF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFADBCMGFFF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFADBCMGFFF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hBNECEELJBJ_.Equals(other.hBNECEELJBJ_))
		{
			return false;
		}
		if (PanelId != other.PanelId)
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
		num ^= hBNECEELJBJ_.GetHashCode();
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
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
		hBNECEELJBJ_.WriteTo(ref output, _repeated_hBNECEELJBJ_codec);
		if (PanelId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PanelId);
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
		num += hBNECEELJBJ_.CalculateSize(_repeated_hBNECEELJBJ_codec);
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFADBCMGFFF other)
	{
		if (other != null)
		{
			hBNECEELJBJ_.Add(other.hBNECEELJBJ_);
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
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
			case 26u:
				hBNECEELJBJ_.AddEntriesFrom(ref input, _repeated_hBNECEELJBJ_codec);
				break;
			case 104u:
				PanelId = input.ReadUInt32();
				break;
			}
		}
	}
}
